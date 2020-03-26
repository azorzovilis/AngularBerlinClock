import { Component, OnInit, Input } from '@angular/core';
import {Lamp} from '../models/lamp';

@Component({
  selector: 'lamp-row',
  templateUrl: './lamp-row.component.html',
  styleUrls: ['./lamp-row.component.css']
})

export class LampRowComponent implements OnInit {

  @Input() berlinClockLamps: Lamp[]  & {lampStyle : string};;

  constructor() { }

  setStyle(lamp: Lamp) : string
  {
    let lampStyle: string;
    if (lamp) {
      if (lamp.colour === 'R') {
        if (lamp.isSwitchedOn) { lampStyle = 'red'; }
        else lampStyle = 'switched-off-red';
      }

      if (lamp.colour === 'Y') {
        if (lamp.isSwitchedOn) { lampStyle = 'yellow'; }
        else lampStyle = 'switched-off-yellow';
      }
    }
    
    return 'box ' + lampStyle;
  }

  ngOnInit(): void {
    this.berlinClockLamps.forEach(lamp => {
      lamp.lampStyle = this.setStyle(lamp);
    });
  }
}