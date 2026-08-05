using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditional")]
    public class Lexv2ModelsIntentConfirmationSettingConfirmationConditional : aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditional
    {
        private object _active;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_intent#active Lexv2ModelsIntent#active}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Active
        {
            get => _active;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _active = value;
            }
        }

        private object? _conditionalBranch;

        /// <summary>conditional_branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_intent#conditional_branch Lexv2ModelsIntent#conditional_branch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalConditionalBranch" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditionalBranch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalConditionalBranch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ConditionalBranch
        {
            get => _conditionalBranch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalConditionalBranch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalConditionalBranch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditionalBranch = value;
            }
        }

        private object? _defaultBranch;

        /// <summary>default_branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/lexv2models_intent#default_branch Lexv2ModelsIntent#default_branch}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranch" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultBranch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DefaultBranch
        {
            get => _defaultBranch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingConfirmationConditionalDefaultBranch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultBranch = value;
            }
        }
    }
}
