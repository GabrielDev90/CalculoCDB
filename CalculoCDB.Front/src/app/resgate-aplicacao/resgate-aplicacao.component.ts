import { FormArray, FormControl, FormGroup, RequiredValidator, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { CalculoCdbService } from 'src/app/shared/servicos/calculo-cdb.service';
import { IResgateCalculoCDB } from '../shared/Interfaces/IResgateCalculoCDB';
import { IResgateCalculoCDBResponse } from '../shared/Interfaces/IResgateCalculoCDBResponse';

@Component({
  selector: 'app-resgate-aplicacao',
  templateUrl: './resgate-aplicacao.component.html',
  styleUrls: ['./resgate-aplicacao.component.css']
})
export class ResgateAplicacaoComponent implements OnInit {
  formGroup: FormGroup
  valorLiquido: number = 0;
  valorBruto: number = 0;

  constructor(private calculoCdbService: CalculoCdbService) { }

  ngOnInit(): void {
    this.formGroup = new FormGroup({
      valor: new FormControl(null, [Validators.required,Validators.min(1)]),
      quantidadeMeses: new FormControl(null, [Validators.required,Validators.min(1)]),
    });
  }

  onSubmit(formData: any) {
    this.calculoCdbService.FazerCalculoCDB(formData).subscribe((resposta: IResgateCalculoCDBResponse) => {
      this.valorLiquido = resposta.valorLiquido;
      this.valorBruto = resposta.valorBruto;
    });
    
  }
}
