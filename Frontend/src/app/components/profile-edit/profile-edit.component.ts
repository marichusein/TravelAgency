import { Component, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-profile-edit',
  templateUrl: './profile-edit.component.html',
  styleUrls: ['./profile-edit.component.css']
})
export class ProfileEditComponent {
  profile: any = {};
  @Input() id:any={};
  @Input() showPopupFlag: boolean=true;
 
  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.editProfile();
  }
  editProfile(): void {
    const id = 'idofuser'; // Replace with the actual user ID
    const apiUrl = `https://localhost:7272/api/Users/GetProfileById?id=${this.id.id}`;
    this.http.get(apiUrl).subscribe((response: any) => {
      this.profile = response;
    });
  }

  updateProfile(): void {
    const updateUrl = 'https://localhost:7272/api/Users/updateuserinfo';
    this.http.post(updateUrl, this.profile).subscribe(() => {
      this.closePopup();
      // Handle success or show notification to the user
    });
  }

  showPopup(): void {
    // Show the popup component
  }

  closePopup(): void {
    this.showPopupFlag = false;
    this.profile={}; 
    this.id.show=false;
  }
}
