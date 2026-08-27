using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationInsightsStandardWebTest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestRequest")]
    public class ApplicationInsightsStandardWebTestRequest : azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_insights_standard_web_test#url ApplicationInsightsStandardWebTest#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_insights_standard_web_test#body ApplicationInsightsStandardWebTest#body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Body
        {
            get;
            set;
        }

        private object? _followRedirectsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_insights_standard_web_test#follow_redirects_enabled ApplicationInsightsStandardWebTest#follow_redirects_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "followRedirectsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FollowRedirectsEnabled
        {
            get => _followRedirectsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _followRedirectsEnabled = value;
            }
        }

        private object? _header;

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_insights_standard_web_test#header ApplicationInsightsStandardWebTest#header}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestRequestHeader" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Header
        {
            get => _header;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestRequestHeader[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestRequestHeader).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _header = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_insights_standard_web_test#http_verb ApplicationInsightsStandardWebTest#http_verb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpVerb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpVerb
        {
            get;
            set;
        }

        private object? _parseDependentRequestsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/application_insights_standard_web_test#parse_dependent_requests_enabled ApplicationInsightsStandardWebTest#parse_dependent_requests_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parseDependentRequestsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ParseDependentRequestsEnabled
        {
            get => _parseDependentRequestsEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parseDependentRequestsEnabled = value;
            }
        }
    }
}
