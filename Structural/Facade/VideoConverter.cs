using Facade.VideoConversion;

namespace Facade
{
    public static class VideoConverter
    {
        public static void Convert()
        {
            AudioMixer.DoSomething();
            BitrateReader.DoSomething();
            CodecFactory.DoSomething();
            Mpeg4CompressionCodec.DoSomething();
            OggCompressionCodec.DoSomething();
            VideoFile.DoSomething();
        }
    }
}