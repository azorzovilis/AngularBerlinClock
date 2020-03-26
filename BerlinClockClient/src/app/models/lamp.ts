export interface Lamp {
    colour: string;
    isSwitchedOn: boolean;
    lampStyle? : string;
}

export interface LampRow {
    lamps: Lamp[];
}