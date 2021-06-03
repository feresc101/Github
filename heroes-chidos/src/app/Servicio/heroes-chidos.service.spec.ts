import { TestBed } from '@angular/core/testing';

import { HeroesChidosService } from './heroes-chidos.service';

describe('HeroesChidosService', () => {
  let service: HeroesChidosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HeroesChidosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
