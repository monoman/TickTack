// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

namespace TickTack;

public static class StringExtensions {
    public static string WithDefault(this string? value, string @default)
        => string.IsNullOrWhiteSpace(value) ? @default : value;
}
