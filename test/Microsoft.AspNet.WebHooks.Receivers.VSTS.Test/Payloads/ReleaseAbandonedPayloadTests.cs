// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.WebHooks.Payloads;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Microsoft.AspNet.WebHooks
{
    public class ReleaseAbandonedPayloadTests
    {
        [Fact]
        public void ReleaseAbandonedPayload_Roundtrips()
        {
            // Arrange
            JObject data = EmbeddedResource.ReadAsJObject("Microsoft.AspNet.WebHooks.Messages.release.abandoned.json");

            var expected = new ReleaseAbandonedPayload
            {
                Id = "b0497ad3-50c9-4722-96da-a8fa5b80d77f",
                EventType = "ms.vss-release.release-abandoned-event",
                PublisherId = "rm",
                Message = new PayloadMessage
                {
                    Text = "Release Release-1 abandoned.",
                    Html = "Release <a href='http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/5'>Release-1</a> abandoned.",
                    Markdown = "Release [Release-1](http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/5) abandoned."
                },
                DetailedMessage = new PayloadMessage
                {
                    Text = "Release Release-1 from release pipeline Fabrikam.CD abandoned.\\r\\nRelease description: QFE release for fixing title\\r\\nContinuousIntegration Requested for Chuck Reinhart\\r\\n<li>Build: fabrikam.Bd.2016.04.10 & 2 more<\\li>",
                    Html = "Release <a href='http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/5'>Release-1</a> from <a href='http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releasedefinitions/1'>Fabrikam.CD</a> release pipeline abandoned.\\r\\n<li>Release description: QFE release for fixing title</li>\\r\\n<li>ContinuousIntegration Requested for Chuck Reinhart</li>\\r\\n<li>Build: fabrikam.Bd.2016.04.10 & 2 more <\\li>",
                    Markdown = "Release [Release-1](http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/5) from release pipeline [Fabrikam.CD](http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releasedefinitions/1) abandoned.\\r\\n<li>Release description: QFE release for fixing title</li>\\r\\n<li>ContinuousIntegration Requested for Chuck Reinhart</li>\\r\\n<li>Build: fabrikam.Bd.2016.04.10 & 2 more<\\li>"
                },

                Resource = new ReleaseResource
                {
                    Release = new Release
                    {
                        Id = 4,
                        Name = "Release-1",
                        Status = "abandoned",
                        CreatedOn = "2016-01-21T08:19:17.26Z".ToDateTime(),
                        ModifiedOn = "2016-01-21T08:19:17.26Z".ToDateTime(),
                        ModifiedBy = new ResourceUser
                        {
                            Id = "4247c988-4060-4712-abca-ff44681dd78a",
                            DisplayName = "Chuck Reinhart"
                        },
                        CreatedBy = new ResourceUser
                        {
                            Id = "4247c988-4060-4712-abca-ff44681dd78a",
                            DisplayName = "Chuck Reinhart"
                        },
                        Variables = new ReleaseVariables(),
                        ReleaseDefinition = new ReleaseReleaseDefinition
                        {
                            Id = 1,
                            Name = "Fabrikam.CD",
                            Url = new Uri("http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/definitions/1")
                        },
                        Description = "QFE release for fixing title",
                        Reason = "continuousIntegration",
                        ReleaseNameFormat = "Release-$(rev:r)",
                        KeepForever = false,
                        DefinitionSnapshotRevision = 0,
                        Comment = "",
                        Links = new ReleaseLinks()
                    },
                    Project = new Project
                    {
                        Id = "00000000-0000-0000-0000-000000000000",
                        Name = "Fabrikam"
                    }
                },
                ResourceVersion = "3.0-preview.1",
                ResourceContainers = new PayloadResourceContainers
                {
                    Collection = new PayloadResourceContainer
                    {
                        Id = "c12d0eb8-e382-443b-9f9c-c52cba5014c2"
                    },
                    Account = new PayloadResourceContainer
                    {
                        Id = "f844ec47-a9db-4511-8281-8b63f4eaf94e"
                    }
                },
                CreatedDate = "2016-09-19T13:03:27.784654Z".ToDateTime()
            };

            var environment = new ReleaseEnvironments
            {
                Id = 5,
                ReleaseId = 0,
                Name = "Dev",
                Status = "succeeded",
                Variables = new ReleaseEnvironmentsVariables(),
                PreApprovalsSnapshot = new ReleaseEnvironmentsPreApprovalsSnapshot
                {
                    ApprovalOptions = new ReleaseEnvironmentsPreApprovalsSnapshotApprovalOptions
                    {
                        RequiredApproverCount = 0,
                        ReleaseCreatorCanBeApprover = true
                    }
                },
                PostApprovalsSnapshot = new ReleaseEnvironmentsPostApprovalsSnapshot(),
                Rank = 1,
                DefinitionEnvironmentId = 1,
                QueueId = 1,
                EnvironmentOptions = new ReleaseEnvironmentsEnvironmentOptions
                {
                    EmailNotificationType = "OnlyOnFailure",
                    EmailRecipients = "release.environment.owner;release.creator",
                    SkipArtifactsDownload = false,
                    TimeoutInMinutes = 0,
                    EnableAccessToken = false
                },
                ModifiedOn = "2016-01-21T08:19:17.26Z".ToDateTime(),
                Owner = new ResourceUser
                {
                    Id = "4247c988-4060-4712-abca-ff44681dd78a",
                    DisplayName = "Chuck Reinhart"
                },
                ScheduledDeploymentTime = "2016-01-21T08:19:17.26Z".ToDateTime(),
                Release = new ReleaseEnvironmentsRelease
                {
                    Id = 5,
                    Name = "Release-1",
                    Url = new Uri("http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/5")
                }
            };
            environment.WorkflowTasks.Add(new ReleaseEnvironmentsWorkflowTask
            {
                TaskId = "00000000-0000-0000-0000-000000000000",
                Version = "*",
                Name = "Deploy Website to Azure",
                Enabled = true,
                AlwaysRun = false,
                ContinueOnError = false,
                TimeoutInMinutes = 0,
                Inputs = new ReleaseEnvironmentsWorkflowTaskInputs
                {
                    ConnectedServiceName = "b460b0f8-fe23-4dc2-a99c-fd8b0633fe1c",
                    WebSiteName = "$(webAppName)",
                    WebSiteLocation = "Southeast Asia",
                    Slot = "",
                    Package = "$(System.DefaultWorkingDirectory)\\**\\*.zip"
                }
            });
            expected.Resource.Release.Environments.Add(environment);

            expected.Resource.Release.Artifacts.Add(new ReleaseArtifact
            {
                SourceId = "31419848-1780-4137-b7e3-62092e986fd6:1",
                Type = "Build",
                Alias = "Fabrikam.CI",
                DefinitionReference = new ReleaseArtifactDefinitionReference
                {
                    Definition = new ReleaseArtifactDefinitionReferenceInfo
                    {
                        Id = "1",
                        Name = "Fabrikam.CI"
                    },
                    Project = new ReleaseArtifactDefinitionReferenceInfo
                    {
                        Id = "31419848-1780-4137-b7e3-62092e986fd6",
                        Name = "Fabrikam"
                    }
                },
                IsPrimary = true
            });

            // Act
            var actual = data.ToObject<ReleaseAbandonedPayload>();

            // Assert
            string expectedJson = JsonConvert.SerializeObject(expected);
            string actualJson = JsonConvert.SerializeObject(actual);
            Assert.Equal(expectedJson, actualJson);
        }
    }
}
