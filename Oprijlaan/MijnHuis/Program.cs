using Philips;
using Heras;
using Infrac;
using DoomsdayPreppers;


Detectielus lus = new Detectielus();
Valkuil kuil = new Valkuil();   
Lamp tl = new Lamp();   
Hek hek = new Hek();

lus.Connect(hek.Open);
lus.Detecting += kuil.Open;
lus.Detecting += tl.Aan;

//lus.Connect(hek);
//lus.Connect(kuil);
//lus.Connect(tl);

// Daar komen ze....
lus.Detect();

