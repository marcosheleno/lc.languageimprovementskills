using GeneralTesting.MultipleClassesSameInterfaceInjection;

// Teste de injeção múltipla para a mesma interface
// OBS.: Nesse cenário a interface estaria descrita em um pacote SharedKernel e a implementação de cada classe, 1 e 2 
//       Estariam em seus respectivos pacotes
var multiInjection = new TestInjection();
multiInjection.Inject();