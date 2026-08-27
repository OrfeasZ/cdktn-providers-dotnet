using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelThreatIntelligenceIndicator
{
    [JsiiInterface(nativeType: typeof(ISentinelThreatIntelligenceIndicatorConfig), fullyQualifiedName: "azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorConfig")]
    public interface ISentinelThreatIntelligenceIndicatorConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#display_name SentinelThreatIntelligenceIndicator#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#pattern SentinelThreatIntelligenceIndicator#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
        string Pattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#pattern_type SentinelThreatIntelligenceIndicator#pattern_type}.</summary>
        [JsiiProperty(name: "patternType", typeJson: "{\"primitive\":\"string\"}")]
        string PatternType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#source SentinelThreatIntelligenceIndicator#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#validate_from_utc SentinelThreatIntelligenceIndicator#validate_from_utc}.</summary>
        [JsiiProperty(name: "validateFromUtc", typeJson: "{\"primitive\":\"string\"}")]
        string ValidateFromUtc
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#workspace_id SentinelThreatIntelligenceIndicator#workspace_id}.</summary>
        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#confidence SentinelThreatIntelligenceIndicator#confidence}.</summary>
        [JsiiProperty(name: "confidence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Confidence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#created_by SentinelThreatIntelligenceIndicator#created_by}.</summary>
        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#description SentinelThreatIntelligenceIndicator#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#extension SentinelThreatIntelligenceIndicator#extension}.</summary>
        [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Extension
        {
            get
            {
                return null;
            }
        }

        /// <summary>external_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#external_reference SentinelThreatIntelligenceIndicator#external_reference}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorExternalReference" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "externalReference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorExternalReference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>granular_marking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#granular_marking SentinelThreatIntelligenceIndicator#granular_marking}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorGranularMarking" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "granularMarking", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorGranularMarking\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GranularMarking
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#id SentinelThreatIntelligenceIndicator#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>kill_chain_phase block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#kill_chain_phase SentinelThreatIntelligenceIndicator#kill_chain_phase}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorKillChainPhase" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "killChainPhase", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorKillChainPhase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KillChainPhase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#language SentinelThreatIntelligenceIndicator#language}.</summary>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Language
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#object_marking_refs SentinelThreatIntelligenceIndicator#object_marking_refs}.</summary>
        [JsiiProperty(name: "objectMarkingRefs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ObjectMarkingRefs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#pattern_version SentinelThreatIntelligenceIndicator#pattern_version}.</summary>
        [JsiiProperty(name: "patternVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatternVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#revoked SentinelThreatIntelligenceIndicator#revoked}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "revoked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Revoked
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#tags SentinelThreatIntelligenceIndicator#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#threat_types SentinelThreatIntelligenceIndicator#threat_types}.</summary>
        [JsiiProperty(name: "threatTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ThreatTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#timeouts SentinelThreatIntelligenceIndicator#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#validate_until_utc SentinelThreatIntelligenceIndicator#validate_until_utc}.</summary>
        [JsiiProperty(name: "validateUntilUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidateUntilUtc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelThreatIntelligenceIndicatorConfig), fullyQualifiedName: "azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#display_name SentinelThreatIntelligenceIndicator#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#pattern SentinelThreatIntelligenceIndicator#pattern}.</summary>
            [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}")]
            public string Pattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#pattern_type SentinelThreatIntelligenceIndicator#pattern_type}.</summary>
            [JsiiProperty(name: "patternType", typeJson: "{\"primitive\":\"string\"}")]
            public string PatternType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#source SentinelThreatIntelligenceIndicator#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#validate_from_utc SentinelThreatIntelligenceIndicator#validate_from_utc}.</summary>
            [JsiiProperty(name: "validateFromUtc", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidateFromUtc
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#workspace_id SentinelThreatIntelligenceIndicator#workspace_id}.</summary>
            [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#confidence SentinelThreatIntelligenceIndicator#confidence}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "confidence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Confidence
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#created_by SentinelThreatIntelligenceIndicator#created_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#description SentinelThreatIntelligenceIndicator#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#extension SentinelThreatIntelligenceIndicator#extension}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Extension
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>external_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#external_reference SentinelThreatIntelligenceIndicator#external_reference}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorExternalReference" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalReference", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorExternalReference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExternalReference
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>granular_marking block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#granular_marking SentinelThreatIntelligenceIndicator#granular_marking}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorGranularMarking" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "granularMarking", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorGranularMarking\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GranularMarking
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#id SentinelThreatIntelligenceIndicator#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kill_chain_phase block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#kill_chain_phase SentinelThreatIntelligenceIndicator#kill_chain_phase}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorKillChainPhase" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "killChainPhase", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorKillChainPhase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KillChainPhase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#language SentinelThreatIntelligenceIndicator#language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Language
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#object_marking_refs SentinelThreatIntelligenceIndicator#object_marking_refs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectMarkingRefs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ObjectMarkingRefs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#pattern_version SentinelThreatIntelligenceIndicator#pattern_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patternVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatternVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#revoked SentinelThreatIntelligenceIndicator#revoked}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revoked", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Revoked
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#tags SentinelThreatIntelligenceIndicator#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#threat_types SentinelThreatIntelligenceIndicator#threat_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threatTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ThreatTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#timeouts SentinelThreatIntelligenceIndicator#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.sentinelThreatIntelligenceIndicator.SentinelThreatIntelligenceIndicatorTimeouts\"}", isOptional: true)]
            public azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SentinelThreatIntelligenceIndicator.ISentinelThreatIntelligenceIndicatorTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/sentinel_threat_intelligence_indicator#validate_until_utc SentinelThreatIntelligenceIndicator#validate_until_utc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateUntilUtc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidateUntilUtc
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
