﻿using System;
using Smartling.Api.Model;

namespace Smartling.Api.Extensions
{
  public static class FileStatusExtensions
  {
    private const int TranslationComplete = 100;

    public static int GetPercentComplete(this FileStatusDetail status)
    {
      return status.totalStringCount == 0
        ? TranslationComplete
        : Convert.ToInt32(
          ((float) status.completedStringCount)/status.totalStringCount * TranslationComplete);
    }
  }
}
