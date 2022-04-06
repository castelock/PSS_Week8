// Declaramos un contenedor Unity
using InyeccionDependencias_Unity;
using Microsoft.Practices.Unity;

var unityContainer = new UnityContainer();

// Registramos IGame para que cuando se detecte la dependencia
// proporcione una instancia de TrivialPursuit
unityContainer.RegisterType<IGame, TrivialPursuit>();

// Hacemos que Unity resuelva la interfaz, proporcionando una instancia
// de la clase TrivialPursuit
var game = unityContainer.Resolve<IGame>();

// Comprobamos que el funcionamiento es correcto
game.addPlayer();
game.addPlayer();
Console.WriteLine(string.Format("{0} personas están jugando a {1}", game.CurrentPlayers, game.Name));
