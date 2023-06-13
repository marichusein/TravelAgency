import { Component, Input, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserStoreService } from 'src/app/Services/user-store.service';
import { AuthService } from 'src/app/Services/auth.service';

@Component({
  selector: 'app-arrangement-form-component',
  templateUrl: './arrangement-form-component.component.html',
  styleUrls: ['./arrangement-form-component.component.css']
})
export class ArrangementFormComponentComponent implements OnInit {
  @Input() userid: any = '';

  countries!: any[];
  cities!: any[];
  accommodations!: any[];
  transports!: any[];

  selectedCountry: any;
  selectedCity: any;
  selectedAccommodation: any;
  selectedTransport: any;
  numberOfPersons: number | undefined;

  constructor(private http: HttpClient, private userStore: UserStoreService, private auth: AuthService) { }

  ngOnInit(): void {
    this.fetchCountries();
    this.fetchTransports();
    this.userStore.getIdFromStore().subscribe((val) => {
      const idFromToken = this.auth.getIdFromToken();
      this.userid = idFromToken || val;
    });
  }

  fetchCountries(): void {
    this.http.get<any[]>('https://localhost:7272/api/Country')
      .subscribe(data => {
        this.countries = data;
      });
  }

  fetchCities(): void {
    if (this.selectedCountry) {
      this.http.get<any[]>('https://localhost:7272/api/City')
        .subscribe(data => {
          this.cities = data.filter(city => city.country.countryID === this.selectedCountry.countryID);
        });
    }
  }

  fetchAccommodations(): void {
    if (this.selectedCity) {
      this.http.get<any[]>('https://localhost:7272/api/Accommodation')
        .subscribe(data => {
          console.log(data);
          this.accommodations = data.filter(accommodation =>
            accommodation.city && accommodation.city.cityID === this.selectedCity.cityID
          );
        });
    }
  }

  fetchTransports(): void {
    this.http.get<any[]>('https://localhost:7272/api/Transportation')
      .subscribe(data => {
        this.transports = data;
      });
  }

  submitForm(): void {
    if (this.selectedCity && this.selectedTransport && this.selectedAccommodation) {
      const destinationPayload = {
        name: 'useradded',
        rate: 0,
        describe: 'useradded',
        price: this.selectedTransport.price + this.selectedAccommodation.price,
        cityId: this.selectedCity.cityID
      };
      this.http.post('https://localhost:7272/api/Destination', destinationPayload)
        .subscribe((destinationResponse: any) => {
          const travelArrangementPayload = {
            destinationID: destinationResponse.destinationID,
            userID: this.userid,
            trnsportID: this.selectedTransport.transportationId,
            accomodationID: this.selectedAccommodation.accommodationID,
            numberOfPerson: this.numberOfPersons
          };
          this.http.post('https://localhost:7272/api/TravelArrangement', travelArrangementPayload)
            .subscribe(() => {
              // Handle success if needed
            });
        });
    }
  }
}
