using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontkeyvaluestoreKeysExclusive
{
    [JsiiInterface(nativeType: typeof(ICloudfrontkeyvaluestoreKeysExclusiveConfig), fullyQualifiedName: "aws.cloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusiveConfig")]
    public interface ICloudfrontkeyvaluestoreKeysExclusiveConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The Amazon Resource Name (ARN) of the Key Value Store.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#key_value_store_arn CloudfrontkeyvaluestoreKeysExclusive#key_value_store_arn}
        /// </remarks>
        [JsiiProperty(name: "keyValueStoreArn", typeJson: "{\"primitive\":\"string\"}")]
        string KeyValueStoreArn
        {
            get;
        }

        /// <summary>Maximum resource key values pairs that you wills update in a single API request.</summary>
        /// <remarks>
        /// AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#max_batch_size CloudfrontkeyvaluestoreKeysExclusive#max_batch_size}
        /// </remarks>
        [JsiiProperty(name: "maxBatchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxBatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_key_value_pair block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#resource_key_value_pair CloudfrontkeyvaluestoreKeysExclusive#resource_key_value_pair}
        /// </remarks>
        [JsiiProperty(name: "resourceKeyValuePair", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePair\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceKeyValuePair
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontkeyvaluestoreKeysExclusiveConfig), fullyQualifiedName: "aws.cloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusiveConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontkeyvaluestoreKeysExclusive.ICloudfrontkeyvaluestoreKeysExclusiveConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Amazon Resource Name (ARN) of the Key Value Store.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#key_value_store_arn CloudfrontkeyvaluestoreKeysExclusive#key_value_store_arn}
            /// </remarks>
            [JsiiProperty(name: "keyValueStoreArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyValueStoreArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Maximum resource key values pairs that you wills update in a single API request.</summary>
            /// <remarks>
            /// AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#max_batch_size CloudfrontkeyvaluestoreKeysExclusive#max_batch_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxBatchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxBatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>resource_key_value_pair block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfrontkeyvaluestore_keys_exclusive#resource_key_value_pair CloudfrontkeyvaluestoreKeysExclusive#resource_key_value_pair}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceKeyValuePair", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontkeyvaluestoreKeysExclusive.CloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePair\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceKeyValuePair
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
