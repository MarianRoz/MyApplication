namespace MyApplication2.Services
{
    public interface IAnnouncementService
    {
        void AddAnnouncement(string announcement);
        void EditAnnouncement(string announcement);
        void DeleteAnnouncement(string announcement);
        void SeeAnnouncement(string announcement);
        void ShowAnnouncement(string announcement);

    }
}
