using System;
using System.Threading.Tasks;

namespace CallService
{
    public class CallRecorder : ICallRecorder
    {
        public Task<bool> PauseRecording()
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResumeRecording()
        {
            throw new NotImplementedException();
        }

        public Task<bool> StartRecording()
        {
            throw new NotImplementedException();
        }

        public Task<bool> StopRecording()
        {
            throw new NotImplementedException();
        }
    }
}
