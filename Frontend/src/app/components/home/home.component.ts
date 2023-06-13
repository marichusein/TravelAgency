import { Component } from '@angular/core';
import { SignalRService } from 'src/app/service/SignalRService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  serverResponseData: any;
  constructor(public s:SignalRService){
  }
  // ngOnInit() {
  //   this.s.openWebsocketChannel();
  // }
  // findCountry() {
  //   let searchValue = document.getElementById('search') as HTMLInputElement;
  //   console.log(searchValue.value);
  //   fetch('https://localhost:7272/api/Country/' + searchValue.value) //api for the get request
  //     .then((response) => response.json())
  //     .then((data) => (this.serverResponseData = data))
  //     .then((data) => console.log(data));
  // }

  
  findCity() {
    let searchValue = document.getElementById('search') as HTMLInputElement;
    console.log(searchValue.value);
    fetch('https://localhost:7272/api/Accommodation/' + searchValue.value) //api for the get request
      .then((response) => response.json())
      .then((data) => (this.serverResponseData = data))
      .then((data) => console.log(data));
  }

  onInputChange(event: Event): void {
    let searchValue = document.getElementById('search') as HTMLInputElement;
    console.log(searchValue.value);
    fetch('https://localhost:7272/api/Accommodation/' + searchValue.value) //api for the get request
      .then((response) => response.json())
      .then((data) => (this.serverResponseData = data))
      .then((data) => console.log(data));
  }

  OpenSignIn() {
    alert('Morate biti prijavljeni :)');
  }
}
