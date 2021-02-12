﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Model.Tests
{
    public class PlayerGameTest
    {

        /// <summary>
        /// Checks the data annotations of Models to make sure they aren't being violated
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private IList<ValidationResult> ValidateModel(object model)
        {
            var result = new List<ValidationResult>();
            var validationContext = new ValidationContext(model);
            Validator.TryValidateObject(model, validationContext, result, true);
            // if (model is IValidatableObject) (model as IValidatableObject).Validate(validationContext);

            return result;
        }

        /// <summary>
        /// Makes sure Game Model works with valid data
        /// </summary>
        [Fact]
        public void ValidatePlayerGame()
        {
            var playerGame = new PlayerGame()
            {
                SeasonID = 1,
                LeagueID = 2
            };

            var results = ValidateModel(playerGame);
            Assert.True(results.Count == 0);
        }
    }
}
