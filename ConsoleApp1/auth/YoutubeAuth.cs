
class YoutubeAuth : IAuth
{
    private string region;
    private string host;
    private string userName;
    private string token;

    public YoutubeAuth(string userName, string token) {
        this.userName = userName;
        this.token = token;
        this.region = "IN";
        this.host = "localhost";
    }

    public void auth()
    {
        youtubeServiceAuth(userName, token, region, host);
    }

    private void youtubeServiceAuth(string userName, string token, string region, string host)
    {
        // do nothing
    }
}