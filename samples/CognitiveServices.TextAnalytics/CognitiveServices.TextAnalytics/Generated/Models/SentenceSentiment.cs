// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The SentenceSentiment. </summary>
    public partial class SentenceSentiment
    {
        /// <summary> Initializes a new instance of SentenceSentiment. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="confidenceScores"/> is null. </exception>
        internal SentenceSentiment(string text, SentenceSentimentValue sentiment, SentimentConfidenceScorePerLabel confidenceScores, int offset, int length)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (confidenceScores == null)
            {
                throw new ArgumentNullException(nameof(confidenceScores));
            }

            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Aspects = new ChangeTrackingList<SentenceAspect>();
            Opinions = new ChangeTrackingList<SentenceOpinion>();
        }

        /// <summary> Initializes a new instance of SentenceSentiment. </summary>
        /// <param name="text"> The sentence text. </param>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="confidenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <param name="aspects"> The array of aspect object for the sentence. </param>
        /// <param name="opinions"> The array of opinion object for the sentence. </param>
        internal SentenceSentiment(string text, SentenceSentimentValue sentiment, SentimentConfidenceScorePerLabel confidenceScores, int offset, int length, IReadOnlyList<SentenceAspect> aspects, IReadOnlyList<SentenceOpinion> opinions)
        {
            Text = text;
            Sentiment = sentiment;
            ConfidenceScores = confidenceScores;
            Offset = offset;
            Length = length;
            Aspects = aspects;
            Opinions = opinions;
        }

        /// <summary> The sentence text. </summary>
        public string Text { get; }
        /// <summary> The predicted Sentiment for the sentence. </summary>
        public SentenceSentimentValue Sentiment { get; }
        /// <summary> The sentiment confidence score between 0 and 1 for the sentence for all classes. </summary>
        public SentimentConfidenceScorePerLabel ConfidenceScores { get; }
        /// <summary> The sentence offset from the start of the document. </summary>
        public int Offset { get; }
        /// <summary> The length of the sentence. </summary>
        public int Length { get; }
        /// <summary> The array of aspect object for the sentence. </summary>
        public IReadOnlyList<SentenceAspect> Aspects { get; }
        /// <summary> The array of opinion object for the sentence. </summary>
        public IReadOnlyList<SentenceOpinion> Opinions { get; }
    }
}
