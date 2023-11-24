using LazyLoading;

// Teste de injeção de dependencias com LayzyLoading
// OBS.: Em um cenário que o construtor faz algum tipo de leitura grande pode ser válido, normalmente não vale a pena
// BenchmarkRunner.Run<DependencyInjection>();
var injection = new DependencyInjection();
injection.Lazy();
injection.Normal();