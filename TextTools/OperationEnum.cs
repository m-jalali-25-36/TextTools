using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTools
{
    enum OperationEnum
    {
        Uppercase,
        TitleCase,
        TitleCaseWithoutSpace,
        TitleCaseWithSpace,
        Lowercase,
        SnakeCase,
        InvertCase,
        TrimLinesStart,
        TrimLinesEnd,
        TrimLines,
        RemoveExtraSpaces,
        ReplaceText,
        SplitText,
        SelectTextByRegex,
        SelectTextByPrefixSuffix,
        TextRepeatLoop,
        StripHtmlTags,
        ReverseText,
        ReverseLine,
        AddLineNumbers,
        Urlencode,
        Urldecode,
        GatheringInALine,
        ApplyControlCharacter,
        FormatJson,
        RemoveDuplicateLines,
        RemoveEmptyLines,
        ConvertToAsciiCodeNumber,
        NumbersOperations,
        AddPrefixSuffixIntoEachLine,
        CountCharacters,
        CountWords,
        CountLines,
    }
}
