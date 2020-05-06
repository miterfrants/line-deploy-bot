namespace LineDeployBot.Models {
    public class AppSettings {
        public Secrets Secrets { get; set; }
    }

    public class Secrets {
        public string ChannelToken { get; set; }
    }
}