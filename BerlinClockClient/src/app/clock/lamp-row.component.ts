import { Component, OnInit, Input } from '@angular/core';
import { Lamp } from '../models/lamp';

@Component({
  selector: 'lamp-row',
  templateUrl: './lamp-row.component.html',
  styleUrls: ['./lamp-row.component.css']
})

export class LampRowComponent implements OnInit {
  @Input() lamps: Lamp[];

  setStyle(lamp: Lamp): string {
    let lampStyle: string = '';

    if (lamp.colour === 'R') {
      lamp.isSwitchedOn ? lampStyle = 'red' : lampStyle = 'switched-off-red';
    }

    if (lamp.colour === 'Y') {
      lamp.isSwitchedOn ? lampStyle = 'yellow' : lampStyle = 'switched-off-yellow';
    }

    return 'box ' + lampStyle;
  }

  ngOnInit(): void {
    this.lamps.forEach(lamp => {
      lamp.lampStyle = this.setStyle(lamp);
    });
  }
}