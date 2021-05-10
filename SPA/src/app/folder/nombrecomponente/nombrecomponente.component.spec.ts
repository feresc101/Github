import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NombrecomponenteComponent } from './nombrecomponente.component';

describe('NombrecomponenteComponent', () => {
  let component: NombrecomponenteComponent;
  let fixture: ComponentFixture<NombrecomponenteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NombrecomponenteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NombrecomponenteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
