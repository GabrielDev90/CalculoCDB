# CalculoCDB
Faz o calculo CDB 

Passo para rodar os projetos.

CalculoCDB.Api
duplo clique na solution "CalculoCDB.sln" o projeto será aberto no Visual Studio. Após isso, basta executar o projeto com F5. 
(é necessário que as versões mais recentes da plataforma .NET -versão 7)

CalculoCDB.Front
basta acessar a pasta raiz do projeto e executar o comando ng s -o (Comando irá rodar a aplicação e abrir uma aba no navegador)

Uma vez que ambas as aplicações estão rodando. Basta fazer a estimativa do cálculo desejado. A aplicação irá retornar o valor bruto e líquido (descontando imposto de renda,verificar tabela no fim do documento)

Utilizando a aplicação.
No campo valor, deverá ser informado qual seria o montante em que o CDB será calculado.
No campo quantidade de meses, deverá ser informado o período em que o valor será calculado.

Uma vez que os campos estão preenchidos basta apertar em calcular. Em caso de dados inválidos, o botão será desabilitado.

A fórmula de cálculo é VF = VI x [1 + (CDI x TB)]

VF é o valor final;
VI é o valor inicial;
CDI é o valor dessa taxa no último mês;
TB é quanto o banco paga sobre o CDI;

Valores CDI e TB
TB – 108%
CDI – 0,9%

exemplo: Valor inicial R$1.000,00 (mil reais)  no período de 2 meses irá mostrar os seguintes valores. 

Valor Bruto: 1019.53
Valor Líquido: 790.14

Tabela para cálculo de imposto de renda

Até 06 meses: 22,5%
Até 12 meses: 20%
Até 24 meses 17,5%
Acima de 24 meses 15%

