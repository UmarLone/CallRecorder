using System.Threading.Tasks;

namespace CallService
{
    public interface ICallRecorder
    {
        Task<bool> StartRecording();
        Task<bool> StopRecording();
        Task<bool> PauseRecording();
        Task<bool> ResumeRecording();
    }
}
