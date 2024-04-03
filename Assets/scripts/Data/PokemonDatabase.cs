using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemonDatabase", menuName = "Database/Pokemon", order = 0)]
public class PokemonDatabase : ScriptableObject
{
    public List<PokemonData> datas = new();
    public void createData()
    {
        if (!datas.Exists(datas => datas.name == "Grenousse"))
        {
            PokemonData.Infos info = new()
            {
                size = 0.3f,
                weight = 7,
                caption = "Son apparente nonchalance est trompeuse. Il change soudainement d’attitude et domine ses adversaires en un clin d’œil.",
                category = "Crapobulle",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Eau, PokemonData.Infos.types.None },
                weakness = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Electrik, PokemonData.Infos.types.Plante },
                resistances = new PokemonData.Infos.types[4] { 
                    PokemonData.Infos.types.Feu, 
                    PokemonData.Infos.types.Glace, 
                    PokemonData.Infos.types.Acier, 
                    PokemonData.Infos.types.Eau 
                }
            };

            PokemonData newPoke = new(
                name: "Grenousse",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Croâporal"))
        {
            PokemonData.Infos info = new()
            {
                size = 0.6f,
                weight = 10.9f,
                caption = "Ce fin stratège sait se servir du terrain à son avantage. Quand il lance des cailloux recouverts d’écume, il ne manque jamais sa cible.",
                category = "Crapobulle",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Eau, PokemonData.Infos.types.None },
                weakness = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Electrik, PokemonData.Infos.types.Plante },
                resistances = new PokemonData.Infos.types[4] { 
                    PokemonData.Infos.types.Feu, 
                    PokemonData.Infos.types.Glace, 
                    PokemonData.Infos.types.Acier, 
                    PokemonData.Infos.types.Eau 
                }
            };

            PokemonData newPoke = new(
                name: "Croâporal",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Amphinobi"))
        {
            PokemonData.Infos info = new()
            {
                size = 1.5f,
                weight = 40f,
                caption = "Sa longue langue enroulée autour de son cou peut sentir les mouvements de l’air. Cela l’aide à détecter les adversaires qu’il ne peut pas voir.",
                category = "Ninja",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Eau, PokemonData.Infos.types.Ténèbres},
                weakness = new PokemonData.Infos.types[5] { 
                    PokemonData.Infos.types.Insecte, 
                    PokemonData.Infos.types.Electrik,
                    PokemonData.Infos.types.Fée,
                    PokemonData.Infos.types.Combat,
                    PokemonData.Infos.types.Plante
                },
                resistances = new PokemonData.Infos.types[6] { 
                    PokemonData.Infos.types.Ténèbres, 
                    PokemonData.Infos.types.Feu,
                    PokemonData.Infos.types.Spectre,
                    PokemonData.Infos.types.Glace, 
                    PokemonData.Infos.types.Acier,
                    PokemonData.Infos.types.Eau
                }
            };

            PokemonData newPoke = new(
                name: "Amphinobi",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Flabébé"))
        {
            PokemonData.Infos info = new()
            {
                size = 0.1f,
                weight = 0.1f,
                caption = "Ce Pokémon parvient à extraire l’énergie cachée des fleurs sauvages. Il aime particulièrement les fleurs rouges.",
                category = "Uniflore",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Fée, PokemonData.Infos.types.None },
                weakness = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Poison, PokemonData.Infos.types.Acier },
                resistances = new PokemonData.Infos.types[3] { 
                    PokemonData.Infos.types.Insecte, 
                    PokemonData.Infos.types.Ténèbres, 
                    PokemonData.Infos.types.Combat 
                }
            };

            PokemonData newPoke = new(
                name: "Flabébé",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Floette"))
        {
            PokemonData.Infos info = new()
            {
                size = 0.2f,
                weight = 0.9f,
                caption = "Ce Pokémon parvient à canaliser le peu d’énergie encore présent dans les fleurs fanées pour leur redonner du tonus. Il tient une fleur rouge.",
                category = "Uniflore",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Fée, PokemonData.Infos.types.None },
                weakness = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Poison, PokemonData.Infos.types.Acier },
                resistances = new PokemonData.Infos.types[3] {
                    PokemonData.Infos.types.Insecte,
                    PokemonData.Infos.types.Ténèbres,
                    PokemonData.Infos.types.Combat
                }
            };

            PokemonData newPoke = new(
                name: "Floette",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Florges"))
        {
            PokemonData.Infos info = new()
            {
                size = 1.1f,
                weight = 10,
                caption = "Ce Pokémon transforme son territoire en magnifique jardin fleuri. Il tire sa puissance des fleurs rouges qui ornent son cou.",
                category = "Jardin",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Fée, PokemonData.Infos.types.None },
                weakness = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Poison, PokemonData.Infos.types.Acier },
                resistances = new PokemonData.Infos.types[3] {
                    PokemonData.Infos.types.Insecte,
                    PokemonData.Infos.types.Ténèbres,
                    PokemonData.Infos.types.Combat
                }
            };

            PokemonData newPoke = new(
                name: "Florges",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Monorpale"))
        {
            PokemonData.Infos info = new()
            {
                size = 0.8f,
                weight = 2,
                caption = "L’âme de Monorpale est celle d’un humain qui a été tué il y a fort longtemps, par la même lame qui forme maintenant son corps.",
                category = "Glaive",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Acier, PokemonData.Infos.types.Spectre },
                weakness = new PokemonData.Infos.types[4] {
                    PokemonData.Infos.types.Ténèbres,
                    PokemonData.Infos.types.Feu,
                    PokemonData.Infos.types.Spectre,
                    PokemonData.Infos.types.Sol
                },
                resistances = new PokemonData.Infos.types[8] { 
                    PokemonData.Infos.types.Dragon, 
                    PokemonData.Infos.types.Fée, 
                    PokemonData.Infos.types.Vol, 
                    PokemonData.Infos.types.Plante,
                    PokemonData.Infos.types.Glace,
                    PokemonData.Infos.types.Psy,
                    PokemonData.Infos.types.Roche,
                    PokemonData.Infos.types.Acier
                }
            };

            PokemonData newPoke = new(
                name: "Monorpale",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Dimoclès"))
        {
            PokemonData.Infos info = new()
            {
                size = 0.8f,
                weight = 4.5f,
                caption = "Il s’est dédoublé en évoluant. Il intimide ses ennemis à grands coups de bruits métalliques en entrechoquant ses deux lames.",
                category = "Glaive",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Acier, PokemonData.Infos.types.Spectre },
                weakness = new PokemonData.Infos.types[4] {
                    PokemonData.Infos.types.Ténèbres,
                    PokemonData.Infos.types.Feu,
                    PokemonData.Infos.types.Spectre,
                    PokemonData.Infos.types.Sol
                },
                resistances = new PokemonData.Infos.types[8] {
                    PokemonData.Infos.types.Dragon,
                    PokemonData.Infos.types.Fée,
                    PokemonData.Infos.types.Vol,
                    PokemonData.Infos.types.Plante,
                    PokemonData.Infos.types.Glace,
                    PokemonData.Infos.types.Psy,
                    PokemonData.Infos.types.Roche,
                    PokemonData.Infos.types.Acier
                }
            };

            PokemonData newPoke = new(
                name: "Dimoclès",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Exagide"))
        {
            PokemonData.Infos info = new()
            {
                size = 1.7f,
                weight = 53,
                caption = "Grâce à son corps en acier et à sa barrière psychique, il peut se défendre en affaiblissant toutes sortes d’attaques.",
                category = "Noble Lame",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Acier, PokemonData.Infos.types.Spectre },
                weakness = new PokemonData.Infos.types[4] {
                    PokemonData.Infos.types.Ténèbres,
                    PokemonData.Infos.types.Feu,
                    PokemonData.Infos.types.Spectre,
                    PokemonData.Infos.types.Sol
                },
                resistances = new PokemonData.Infos.types[8] {
                    PokemonData.Infos.types.Dragon,
                    PokemonData.Infos.types.Fée,
                    PokemonData.Infos.types.Vol,
                    PokemonData.Infos.types.Plante,
                    PokemonData.Infos.types.Glace,
                    PokemonData.Infos.types.Psy,
                    PokemonData.Infos.types.Roche,
                    PokemonData.Infos.types.Acier
                }
            };

            PokemonData newPoke = new(
                name: "Exagide",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }

        if (!datas.Exists(datas => datas.name == "Zygarde")){
            PokemonData.Infos info = new()
            {
                size = 5,
                weight = 305.0f,
                caption = "La forme que Zygarde prend lorsqu’il rassemble 50 % de ses Cellules. Sa mission est de surveiller l’écosystème.",
                category = "Equilibre",
                type = new PokemonData.Infos.types[2] { PokemonData.Infos.types.Dragon, PokemonData.Infos.types.Sol },
                weakness = new PokemonData.Infos.types[2] { 
                    PokemonData.Infos.types.Dragon, 
                    PokemonData.Infos.types.Fée 
                },
                resistances = new PokemonData.Infos.types[3] { 
                    PokemonData.Infos.types.Feu, 
                    PokemonData.Infos.types.Poison, 
                    PokemonData.Infos.types.Roche, 
                }
            };

            PokemonData newPoke = new(
                name: "Zygarde",
                icon: null,
                info: info
            );
            datas.Add(newPoke);
        }
    }
}
