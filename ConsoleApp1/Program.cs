// Person a = new Person("Asyraf", 17);

// Person b = new Person();

// System.Console.WriteLine(a);
// System.Console.WriteLine(b);


// IAnimal a = new Gajah();
// IAnimal b = new Fish();

// a.sound();
// b.sound();

using System.Dynamic;

List<int> a = new List<int>();
a.Add(1);
a.Add(1);

HashSet<int> b = new HashSet<int>();
b.Add(1);
b.Add(1);

void login(ReqBody reqBody) {
    IAuth authentication = checkProvider(reqBody);
    authentication.auth();
}

IAuth checkProvider(ReqBody req)
{
    if (req.provider == "youtube") {
        return new YoutubeAuth(req.userName, req.youtubeToken);
    } else if (req.provider == "facebook") {
        return new FacebookAuth(req.facebookToken);
    } else if (req.provider == "google") {
        return new GoogleAuth(req.userName, req.password);
    }  else {
        throw new Exception("Provider not yet available");
    }
}