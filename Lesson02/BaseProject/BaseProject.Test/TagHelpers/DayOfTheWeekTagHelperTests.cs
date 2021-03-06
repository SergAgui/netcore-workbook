﻿using BaseProject.Intrastructure;
using FluentAssertions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Moq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BaseProject.Test.TagHelpers
{
    public class MyMockedDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now { get; set; }
    }
    public class DayOfTheWeekTagHelperTests
    {
        [Fact]
        public void TagHelper_ShouldShowCurrentDayOfTheWeek()
        {
            var now = DateTime.Now;
            foreach (var day in Enumerable.Range(0, 6).Select(i => now.AddDays(i)))
            {
                // Assemble
                var mockDateTimeProvider = new MyMockedDateTimeProvider();
                mockDateTimeProvider.Now = day;
                TagHelper myTagHelper = new DayOfTheWeekTagHelper(mockDateTimeProvider);
                TagHelperContext context = null;
                TagHelperOutput output = new TagHelperOutput(
                    "day-of-week",
                    new TagHelperAttributeList(),
                    (useCachedResult, encoder) =>
                    {
                        var tagHelperContent = new DefaultTagHelperContent();
                        tagHelperContent.SetContent(string.Empty);
                        return Task.FromResult<TagHelperContent>(tagHelperContent);
<<<<<<< HEAD
                    });

                // Act
                myTagHelper.Process(context, output);
=======
                    }
                );

                // Act
                myTagHelper.Process(context, output);

                // Assert
                Assert.Contains(mockDateTimeProvider.Now.DayOfWeek.ToString(), output.Content.GetContent());
            }
        }

        [Fact]
        public void TagHelper_ShouldBoldDayOfTheWeek()
        {
            var now = DateTime.Now;
            // Assemble
            var mockDateTimeProvider = new MyMockedDateTimeProvider();
            mockDateTimeProvider.Now = now;
            TagHelper myTagHelper = new DayOfTheWeekTagHelper(mockDateTimeProvider);
            TagHelperContext context = null;
            TagHelperOutput output = new TagHelperOutput(
                "day-of-week",
                new TagHelperAttributeList(),
                (useCachedResult, encoder) =>
                {
                    var tagHelperContent = new DefaultTagHelperContent();
                    tagHelperContent.SetContent(string.Empty);
                    return Task.FromResult<TagHelperContent>(tagHelperContent);
                }
            );
>>>>>>> b1d12eb330076f9df7bde8448fea9a99b947b17e

                // Assert
                // Show current day
                Assert.Contains(mockDateTimeProvider.Now.DayOfWeek.ToString(), output.Content.GetContent());
            }
        }
    }

    public class BoldTagHelperTests
    {
        [Fact]
        public void TagHelper_ShouldShowBoldDay()
        {
            var now = DateTime.Now;
            foreach (var day in Enumerable.Range(0, 6).Select(i => now.AddDays(i)))
            {
                // Assemble
                var mockDateTimeProvider = new MyMockedDateTimeProvider();
                mockDateTimeProvider.Now = day;
                TagHelper myTagHelper = new DayOfTheWeekTagHelper(mockDateTimeProvider);
                TagHelperContext context = null;
                TagHelperOutput output = new TagHelperOutput(
                    "b",
                    new TagHelperAttributeList(),
                    (useCachedResult, encoder) =>
                    {
                        var tagHelperContent = new DefaultTagHelperContent();
                        tagHelperContent.SetContent(string.Empty);
                        return Task.FromResult<TagHelperContent>(tagHelperContent);
                    });

<<<<<<< HEAD
                // Act
                myTagHelper.Process(context, output);

                // Assert
                // Show current day
                Assert.Equal("b", output.TagName);
            }
=======
            // Assert
            var content = output.Content.GetContent();
            Assert.Equal("b", output.TagName);
>>>>>>> b1d12eb330076f9df7bde8448fea9a99b947b17e
        }
    }
}
