import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CabaceraComponent } from './cabacera.component';

describe('CabaceraComponent', () => {
  let component: CabaceraComponent;
  let fixture: ComponentFixture<CabaceraComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CabaceraComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CabaceraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
