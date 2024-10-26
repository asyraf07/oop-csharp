
class FacebookAuth : IAuth
{
    private string userToken;
    public FacebookAuth(string userToken) {
        this.userToken = userToken;
    }
    public void auth()
    {
        facebookServiceAuth(userToken);
    }

    private void facebookServiceAuth(string userToken)
    {
        // do nothing
    }
}