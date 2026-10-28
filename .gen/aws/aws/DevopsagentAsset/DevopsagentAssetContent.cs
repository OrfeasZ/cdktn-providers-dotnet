using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsagentAsset
{
    [JsiiByValue(fqn: "aws.devopsagentAsset.DevopsagentAssetContent")]
    public class DevopsagentAssetContent : aws.DevopsagentAsset.IDevopsagentAssetContent
    {
        private object? _file;

        /// <summary>file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#file DevopsagentAsset#file}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentFile" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? File
        {
            get => _file;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DevopsagentAsset.IDevopsagentAssetContentFile[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DevopsagentAsset.IDevopsagentAssetContentFile).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _file = value;
            }
        }

        private object? _sourceUrl;

        /// <summary>source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#source_url DevopsagentAsset#source_url}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentSourceUrl" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceUrl
        {
            get => _sourceUrl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DevopsagentAsset.IDevopsagentAssetContentSourceUrl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DevopsagentAsset.IDevopsagentAssetContentSourceUrl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceUrl = value;
            }
        }

        private object? _zip;

        /// <summary>zip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/devopsagent_asset#zip DevopsagentAsset#zip}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DevopsagentAsset.IDevopsagentAssetContentZip" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsagentAsset.DevopsagentAssetContentZip\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Zip
        {
            get => _zip;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DevopsagentAsset.IDevopsagentAssetContentZip[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DevopsagentAsset.IDevopsagentAssetContentZip).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _zip = value;
            }
        }
    }
}
