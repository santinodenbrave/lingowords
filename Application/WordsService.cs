﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lingowords.Domain;

namespace lingowords.Services
{
    public interface IWordsService
    {
        IList<Word> CheckWords();

        string CheckWord(string text);
    }
}
