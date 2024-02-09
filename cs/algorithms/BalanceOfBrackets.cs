using System.Collections.Generic;
using System.Linq;

namespace Studying.Leetcode.Algorithms
{
    /// <summary>
    /// 
    /// </summary>
    public class BalanceOfBrackets : Studying.Leetcode.ILeetcodeProblem
    {
        public void Execute()
        {
            // 
            System.Console.WriteLine(IsBalanced("()[][{}]"));   // true
            System.Console.WriteLine(IsBalanced("[}"));         // false
            System.Console.WriteLine(IsBalanced("})[]{}"));     // false
            System.Console.WriteLine(IsBalanced("(}"));         // false
            System.Console.WriteLine(IsBalanced("({https://google.com})"));     // true
            System.Console.WriteLine(IsBalanced("{}a"));        // true
        }

        private bool IsBalanced(string text)
        {
            // Массив допустимых символов (все открывающие и закрывающие скобки).
            var allowedSymbols = new Dictionary<char, char>();
            allowedSymbols.Add('{', '}');
            allowedSymbols.Add('(', ')');
            allowedSymbols.Add('[', ']');

            // Для того, чтобы хранить информацию по открытым/закрытым скобкам, создадим словарь <char, int>.
            var symbols = new Dictionary<char, int>();

            // Заполним словарь допустимыми значениями.
            foreach (var key in allowedSymbols.Keys)
            {
                symbols.Add(key, 0);
            }
            foreach (var value in allowedSymbols.Values)
            {
                symbols.Add(value, 0);
            }

            // В цикле посимвольно пробегаем по тексту.
            // Если символ равен одному из допустимых символов, то увеличиваем количество в словаре на 1.
            // Если после увеличения количества для текущего символа получается так, что количество 
            // закрывающих больше количества открывающих, то возвращаем false.
            foreach (var character in text)
            {
                int value = 0;
                if (symbols.TryGetValue(character, out value))
                {
                    symbols[character] = value + 1;
                    if (allowedSymbols.ContainsValue(character))
                    {
                        var key = allowedSymbols.FirstOrDefault(x => x.Value == character).Key;
                        if (symbols[character] > symbols[key])
                            return false;
                    }
                }
                else
                {
                    continue;
                }
            }

            // Пробежать по допустимым символам, взять ключи, по ключу найти закрывающий символ.
            // В словаре сиволов со значениями, получить количество закрывающих и открывающих символов.
            // Если количество символов не равно, то возвращаем false, т.к. строка не сбалансирована.
            // Если цикл закончился, то возвращаем true.
            foreach (var openSymbol in allowedSymbols.Keys)
            {
                var closeSymbol = allowedSymbols[openSymbol];
                if (symbols[openSymbol] != symbols[closeSymbol])
                    return false;
            }
            return true;
        }
    }
}