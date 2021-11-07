namespace Task05_3
{
    public class VideoFile
    {
        public string _name;
        public int _duration;
        public int _quality;

        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public int Size => _duration * _quality;

        public override string ToString()
        {
            return (
                $"Наименование видеофайла: {_name}\nДлительность в секундах: {_duration}\nКачество видеофайла: {_quality}\nРазмер видеофайла: {Size}\n");
        }
    }
}