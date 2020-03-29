import { Component, Input } from '@angular/core';
import { Lamp } from '../models/lamp';

@Component({
  selector: 'lamp-circle',
  templateUrl: './lamp-circle.component.html',
  styleUrls: ['./lamp-circle.component.css']
})

export class LampCircleComponent {
  @Input() lamp: Lamp;
}