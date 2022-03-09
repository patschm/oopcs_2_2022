using RadioStation;

RadioZender r538 = new RadioZender();

r538.Zend += OntvangstMethodes.ViaRooksignalen;
r538.Zend += OntvangstMethodes.ViaKabel;
r538.Zend += OntvangstMethodes.ViaPostduif;
r538.Zend += OntvangstMethodes.ViaKabel;
r538.Zend += OntvangstMethodes.ViaEther;
r538.Zend += OntvangstMethodes.ViaSMS;
r538.Zend += OntvangstMethodes.ViaRooksignalen;
r538.Zend += OntvangstMethodes.ViaKabel;
r538.Zend += OntvangstMethodes.ViaPostduif;
r538.Zend += OntvangstMethodes.ViaKabel;
r538.Zend += OntvangstMethodes.ViaEther;
r538.Zend += OntvangstMethodes.ViaSMS;
r538.Zend += OntvangstMethodes.ViaRooksignalen;
r538.Zend += OntvangstMethodes.ViaKabel;
r538.Zend += OntvangstMethodes.ViaPostduif;
r538.Zend += OntvangstMethodes.ViaKabel;
r538.Zend += OntvangstMethodes.ViaEther;
r538.Zend += OntvangstMethodes.ViaSMS;

r538.Broadcast();


