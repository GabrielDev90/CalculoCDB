import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CalculoCDBServicoEnum } from '../Enums/CalculoCDBServicoEnum';
import { environment } from 'src/environments/environment';
import { IResgateCalculoCDB } from '../Interfaces/IResgateCalculoCDB';

@Injectable({
  providedIn: 'root'
})
export class CalculoCdbService {

  private readonly url: string;

  constructor(private httpClient: HttpClient) {
    this.url = environment.backendUrlApi
  }

  public FazerCalculoCDB(resageteCalculo: IResgateCalculoCDB): Observable<any> {
    return this.httpClient.get(this.url + CalculoCDBServicoEnum.CalcularCDB + "/" + resageteCalculo.valor + "/" + resageteCalculo.quantidadeMeses
    );
  }
}
