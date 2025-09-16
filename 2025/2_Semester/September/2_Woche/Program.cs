using ConsoleApp7;

List<Auto> autos =
[
  new Auto { Marke = "BMW", Model = "M3", Ps = 480},
    new Auto { Marke = "Audi", Model = "R56", Ps = 380},
      new Auto { Marke = "Porsche", Model = "idk", Ps = 280}
];

Auto auto = new() {Marke = "Porsche", Model = "911", Ps = 500};
autos.Add(auto);
autos[2].Starten(.;
