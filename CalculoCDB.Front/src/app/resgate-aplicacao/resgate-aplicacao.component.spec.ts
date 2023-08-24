import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResgateAplicacaoComponent } from './resgate-aplicacao.component';

describe('ResgateAplicacaoComponent', () => {
  let component: ResgateAplicacaoComponent;
  let fixture: ComponentFixture<ResgateAplicacaoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ResgateAplicacaoComponent]
    });
    fixture = TestBed.createComponent(ResgateAplicacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
