﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using Microsoft.VisualStudio.Language.Intellisense;

namespace dnSpy.Contracts.Language.Intellisense.Classification {
	/// <summary>
	/// <see cref="ICompletionClassifier"/> context
	/// </summary>
	public abstract class CompletionClassifierContext {
		/// <summary>
		/// Context kind
		/// </summary>
		public abstract CompletionClassifierKind Kind { get; }

		/// <summary>
		/// Gets the collection
		/// </summary>
		public CompletionSet CompletionSet { get; }

		/// <summary>
		/// Gets the completion to classify
		/// </summary>
		public Completion Completion { get; }

		/// <summary>
		/// Gets all text to classify
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="completionSet">Completion set</param>
		/// <param name="completion">Completion to classify</param>
		/// <param name="text">Text to classify</param>
		protected CompletionClassifierContext(CompletionSet completionSet, Completion completion, string text) {
			if (completionSet == null)
				throw new ArgumentNullException(nameof(completionSet));
			if (completion == null)
				throw new ArgumentNullException(nameof(completion));
			if (text == null)
				throw new ArgumentNullException(nameof(text));
			CompletionSet = completionSet;
			Completion = completion;
			Text = text;
		}
	}
}
