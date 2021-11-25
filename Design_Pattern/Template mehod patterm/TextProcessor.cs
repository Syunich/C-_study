using System.IO;

/// <summary>
/// Template method pattern
/// </summary>

namespace TextFileProcessor
{

    /// <summary>
    /// ファイルに対して一行ずつ何かを行う。
    /// </summary>
    abstract class TextProcessor
    {

        //最基底クラスTextProcessorが関数Runをもつ。Tの条件は
        //①TextProcessorまたはそれを継承しているクラス
        //②引数無しでnewできること
        public static void Run<T>(string Filename) where T : TextProcessor, new()
        {
            var self = new T();
            self.Process(Filename);
        }

        private void Process(string Filename)
        {
            Initialize(Filename);
            using (var sr = new StreamReader(Filename))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    Execute(line);
                }
            }
            Terminate();
        }

        /// <summary>
        /// User can set the action First of Run.
        /// </summary>
        /// <param name="Filename"></param>
        protected virtual void Initialize(string Filename) { }

        /// <summary>
        /// User can set the action for readed each line.
        /// </summary>
        protected virtual void Execute(string line) { }

        /// <summary>
        /// Use can set the action finally
        /// </summary>
        protected virtual void Terminate() { }

    }
}
