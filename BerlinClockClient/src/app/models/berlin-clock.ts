import { LampRow } from './lamp';

export interface BerlinClock {
    utcTime: string;
    seconds: LampRow;
    minutesAndHours: LampRow[];
}

export interface Clock {
    utcTime: string;
    lampRows: LampRow[];
}