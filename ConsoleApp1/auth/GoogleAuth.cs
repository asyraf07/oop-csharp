class GoogleAuth : IAuth
{

    private string email;
    private string password;

    public GoogleAuth(string email, string password) {
        this.email = email;
        this.password = password;
    }

    public void auth()
    {
        googleServiceAuth("email", "asdf");
    }

    public void googleServiceAuth(string email, string password) {
        // do nothing
    }
}