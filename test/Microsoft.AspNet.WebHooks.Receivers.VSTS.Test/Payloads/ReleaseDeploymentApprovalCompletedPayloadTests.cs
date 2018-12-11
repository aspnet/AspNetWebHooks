// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.WebHooks.Payloads;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Microsoft.AspNet.WebHooks
{
    public class ReleaseDeploymentApprovalCompletedPayloadTests
    {
        [Fact]
        public void ReleaseDeploymentApprovalCompletedPayloadTests_Roundtrips()
        {
            // Arrange
            JObject data = EmbeddedResource.ReadAsJObject("Microsoft.AspNet.WebHooks.Messages.release.deployment.approval.completed.json");

            var expected = new ReleaseDeploymentApprovalCompletedPayload
            {
                Id = "106acb39-c61e-4efd-995e-a9f5e71ba3cd",
                EventType = "ms.vss-release.deployment-approval-completed-event",
                PublisherId = "rm",
                Message = new PayloadMessage
                {
                    Text = "Pre Deployment approval for deployment of release Release-1 on environment Dev Succeeded.",
                    Html = "Pre Deployment approval for release <a href='http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/1'>Release-1</a> on environment <a href='http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/definitions/1'>Dev</a> Succeeded.",
                    Markdown = "Pre Deployment approval for deployment of release [Release-1](http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/1) on environment [Dev](http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/definitions/1) Succeeded."
                },
                DetailedMessage = new PayloadMessage
                {
                    Text = "Pre Deployment approval for release Release-1 on environment Dev Succeeded.\\r\\nApprover: Chuck Reinhart\\r\\nComment: Approving",
                    Html = "Pre Deployment approval for release <a href='http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/1'>Release-1</a> on environment <a href='http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/definitions/1'>Dev</a>  Succeeded.\\r\\nApprover: Chuck Reinhart\\r\\nComment: Approving",
                    Markdown = "Pre Deployment approval for release [Release-1](http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/1) on environment [Dev](http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/definitions/1) Succeeded.\\r\\nApprover: Chuck Reinhart\\r\\nComment: Approving"
                },
                
                Resource = new ReleaseDeploymentApprovalCompletedResource
                {
                    Approval = new Approval
                    {
                        Id = 0,
                        Revision = 0,
                        Approver = new ResourceUser
                        {
                            Id = "4247c988-4060-4712-abca-ff44681dd78a",
                            DisplayName = "Chuck Reinhart"
                        },
                        ApprovedBy = new ResourceUser
                        {
                            Id = "4247c988-4060-4712-abca-ff44681dd78a",
                            DisplayName = "Chuck Reinhart"
                        },
                        ApprovalType = "preDeploy",
                        CreatedOn = "2016-01-21T08:19:17.26Z".ToDateTime(),
                        ModifiedOn = "2016-01-21T08:19:17.26Z".ToDateTime(),
                        Status = "approved",
                        Comments = "",
                        IsAutomated = false,
                        IsNotificationOn = true,
                        TrialNumber = 1,
                        Attempt = 0,
                        Rank = 1,
                        Release = new Release
                        {
                            Id = 1,
                            Name = "Release-1"
                        },
                        ReleaseDefinition = new ReleaseDefinition
                        {
                            Id = 1,
                            Name = "Fabrikam.CD",
                            Url = new Uri("http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/definitions/1")
                        },
                        ReleaseEnvironment = new ReleaseEnvironments
                        {
                            Id = 8,
                            Name = "Dev"
                        }
                    },
                    Release = new Release
                    {
                        Id = 1,
                        Name = "Release-1",
                        Status = "active",
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
                        ReleaseDefinition = new ReleaseDefinition
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
                CreatedDate = "2016-09-19T13:03:28.1594606Z".ToDateTime()
            };

            var environment = new ReleaseEnvironments
            {
                Id = 1,
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
                    Id = 1,
                    Name = "Release-1",
                    Url = new Uri("http://vsrm.dev.azure.com/fabfiber/DefaultCollection/Fabrikam-Fiber-Git/_apis/Release/releases/1")
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
            var actual = data.ToObject<ReleaseDeploymentApprovalCompletedPayload>();

            // Assert
            string expectedJson = JsonConvert.SerializeObject(expected);
            string actualJson = JsonConvert.SerializeObject(actual);
            Assert.Equal(expectedJson, actualJson);
        }
    }
}
