import { TestBed } from '@angular/core/testing';

import { CalculoCdbService } from './calculo-cdb.service';

describe('CalculoCdbService', () => {
  let service: CalculoCdbService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculoCdbService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
