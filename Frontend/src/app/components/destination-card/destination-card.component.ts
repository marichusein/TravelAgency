import { Component, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { PopUpComponent } from '../pop-up/pop-up.component';

@Component({
  selector: 'app-destination-card',
  templateUrl: './destination-card.component.html',
  styleUrls: ['./destination-card.component.css']
})

export class DestinationCardComponent {
  @Input() destination: any;
  @Input() showPopup: any;
  @Input() basicUser!:boolean;

  // showPopup:any;
  constructor(private dialog: MatDialog) { 
  }
  ngOnInit(){
    // this.basicUser=true;
  }

  openPopup() {
    this.showPopup = true;
    console.log(this.showPopup);

  }
  closePopup() {
    console.log(this.showPopup);

    this.showPopup = false;
  }
}
