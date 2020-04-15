import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'stylingPipe'
})
export class StylingPipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    return null;
  }

}
