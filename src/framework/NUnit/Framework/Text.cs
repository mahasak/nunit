// ***********************************************************************
// Copyright (c) 2009 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

// ****************************************************************
//              Generated by the NUnit Syntax Generator
//
// Command Line: GenSyntax.exe -syntax:SyntaxElements.txt Shared/Framework/Is.cs Shared/Framework/Has.cs NUnit/Framework/Text.cs Shared/Framework/Throws.cs Shared/Framework/Constraints/ConstraintFactory.cs Shared/Framework/Constraints/ConstraintExpression.cs Shared/Framework/Assert.cs
// 
//                  DO NOT MODIFY THIS FILE DIRECTLY
// ****************************************************************

using System;
using System.Collections;
using NUnit.Framework.Constraints;

namespace NUnit.Framework
{
    /// <summary>
    /// Helper class with static methods used to supply constraints
    /// that operate on strings.
    /// </summary>
    [Obsolete("Use Is class for string constraints")]
    public class Text
    {
        #region All

        /// <summary>
        /// Returns a ConstraintExpression, which will apply
        /// the following constraint to all members of a collection,
        /// succeeding if all of them succeed.
        /// </summary>
        [Obsolete("Use Is.All")]
        public static ConstraintExpression All
        {
            get { return new ConstraintExpression().All; }
        }

        #endregion

        #region Contains

        /// <summary>
        /// Returns a constraint that succeeds if the actual
        /// value contains the substring supplied as an argument.
        /// </summary>
        [Obsolete("Use Is.StringContaining")]
        public static SubstringConstraint Contains(string expected)
        {
            return new SubstringConstraint(expected);
        }

        #endregion

        #region DoesNotContain

        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value contains the substring supplied as an argument.
        /// </summary>
        [Obsolete("Use Is.Not.StringContaining")]
        public static SubstringConstraint DoesNotContain(string expected)
        {
            return new ConstraintExpression().Not.ContainsSubstring(expected);
        }

        #endregion

        #region DoesNotStartWith

        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value starts with the substring supplied as an argument.
        /// </summary>
        public static StartsWithConstraint DoesNotStartWith(string expected)
        {
            return new ConstraintExpression().Not.StartsWith(expected);
        }

        #endregion

        #region EndsWith

        /// <summary>
        /// Returns a constraint that succeeds if the actual
        /// value ends with the substring supplied as an argument.
        /// </summary>
        [Obsolete("Use Is.StringEnding")]
        public static EndsWithConstraint EndsWith(string expected)
        {
            return new EndsWithConstraint(expected);
        }

        #endregion

        #region DoesNotEndWith

        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value ends with the substring supplied as an argument.
        /// </summary>
        public static EndsWithConstraint DoesNotEndWith(string expected)
        {
            return new ConstraintExpression().Not.EndsWith(expected);
        }

        #endregion

        #region Matches

#if !NETCF
        /// <summary>
        /// Returns a constraint that succeeds if the actual
        /// value matches the regular expression supplied as an argument.
        /// </summary>
        [Obsolete("Use Is.StringMatching")]
        public static RegexConstraint Matches(string pattern)
        {
            return new RegexConstraint(pattern);
        }
#endif

        #endregion

        #region DoesNotMatch

#if !NUNITLITE
        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value matches the pattern supplied as an argument.
        /// </summary>
        [Obsolete]
        public static RegexConstraint DoesNotMatch(string pattern)
        {
            return new ConstraintExpression().Not.Matches(pattern);
        }
#endif

        #endregion

    }
}
