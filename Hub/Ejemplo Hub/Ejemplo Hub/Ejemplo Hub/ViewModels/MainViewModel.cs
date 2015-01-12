using Ejemplo_Hub.Models;
using System.Collections.Generic;

namespace Ejemplo_Hub.ViewModels
{
    public class MainViewModel
    {

        public List<Game> Games
        {
            get;
            set;
        }

        public MainViewModel()
        {
            Games = new List<Game>();
            Games.Add(new Game { Title = "Forza Motorsport 5", Description = "Forza Motorsport, la franquicia de carreras mejor valorada de la última década, vuelve con una experiencia de conducción total de última generación creada en exclusiva para Xbox One.", Image = "http://compass.xboxlive.com/assets/cb/19/cb19177d-969a-48dc-91f2-d6e8416968d6.jpg?n=XBR_Game1.jpg" });
            Games.Add(new Game { Title = "Ryse", Description = "En medio del caos de la última etapa del Imperio Romano, conviértete en el soldado Marius Titus y súmate a una trepidante campaña para vengar la muerte de tu familia.", Image = "http://compass.xboxlive.com/assets/69/d2/69d2d734-7a15-40b5-a7b9-9baea1937c40.jpg?n=XBR_Game4.jpg" });
            Games.Add(new Game { Title = "Dead Rising 3", Description = "Todo vale como arma en Dead Rising 3. Explora la ciudad de Los Perdidos (California) como Nick Ramos, un mecánico con un pasado misterioso, que debe encontrar el modo de escapar antes de que un ataque militar acabe con la ciudad y todos sus habitantes.", Image = "http://compass.xboxlive.com/assets/83/c7/83c74b66-5f24-4263-bc03-3c3c021c4a11.jpg?n=XBR_Game5.jpg" });
            Games.Add(new Game { Title = "Call of Duty: Ghosts", Description = "La franquicia que ha sentado las bases de toda una generación de juegos se pone el listón aún más alto con el nuevo Call of Duty: Ghosts.", Image = "http://compass.xboxlive.com/assets/07/bb/07bbfdcf-646b-4ac9-b764-c8253e7dabc3.jpg?n=XBR_Game3.jpg" });
            Games.Add(new Game { Title = "Quatum Break", Description = "Domina el tiempo para sobrevivir al presente… y salva el futuro. De los creadores de Alan Wake y Max Payne llega Quantum Break, una experiencia de entretenimiento revolucionaria a medio camino entre el juego y la televisión.", Image = "http://compass.xboxlive.com/assets/aa/84/aa842d82-5c4e-4292-a12c-432af66f1e53.jpg?n=XBR_Game2.jpg" });
        }
    }
}
