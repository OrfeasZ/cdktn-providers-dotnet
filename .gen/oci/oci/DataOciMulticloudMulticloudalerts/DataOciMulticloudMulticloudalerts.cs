using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMulticloudMulticloudalerts
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/multicloud_multicloudalerts oci_multicloud_multicloudalerts}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalerts), fullyQualifiedName: "oci.dataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalerts", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsConfig\"}}]")]
    public class DataOciMulticloudMulticloudalerts : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/multicloud_multicloudalerts oci_multicloud_multicloudalerts} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMulticloudMulticloudalerts(Constructs.Construct scope, string id, oci.DataOciMulticloudMulticloudalerts.IDataOciMulticloudMulticloudalertsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMulticloudMulticloudalerts.IDataOciMulticloudMulticloudalertsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMulticloudMulticloudalerts(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMulticloudMulticloudalerts(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMulticloudMulticloudalerts resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMulticloudMulticloudalerts to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMulticloudMulticloudalerts that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMulticloudMulticloudalerts to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMulticloudMulticloudalerts to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/data-sources/multicloud_multicloudalerts#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMulticloudMulticloudalerts that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMulticloudMulticloudalerts to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalerts), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMulticloudMulticloudalerts.IDataOciMulticloudMulticloudalertsFilter" />)[]</param>
        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataOciMulticloudMulticloudalerts.IDataOciMulticloudMulticloudalertsFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciMulticloudMulticloudalerts.IDataOciMulticloudMulticloudalertsFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciMulticloudMulticloudalerts.IDataOciMulticloudMulticloudalertsFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlertFunctionName")]
        public virtual void ResetAlertFunctionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlertStatus")]
        public virtual void ResetAlertStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlertType")]
        public virtual void ResetAlertType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimit")]
        public virtual void ResetLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceId")]
        public virtual void ResetResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceType")]
        public virtual void ResetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSeverity")]
        public virtual void ResetSeverity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionId")]
        public virtual void ResetSubscriptionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionServiceName")]
        public virtual void ResetSubscriptionServiceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalerts))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"oci.dataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsFilterList\"}")]
        public virtual oci.DataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsFilterList Filter
        {
            get => GetInstanceProperty<oci.DataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsFilterList>()!;
        }

        [JsiiProperty(name: "multicloudAlertCollection", typeJson: "{\"fqn\":\"oci.dataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsMulticloudAlertCollectionList\"}")]
        public virtual oci.DataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsMulticloudAlertCollectionList MulticloudAlertCollection
        {
            get => GetInstanceProperty<oci.DataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsMulticloudAlertCollectionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertFunctionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlertFunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlertStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlertTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciMulticloudMulticloudalerts.IDataOciMulticloudMulticloudalertsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciMulticloudMulticloudalerts.DataOciMulticloudMulticloudalertsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "severityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SeverityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionServiceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubscriptionServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "alertFunctionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlertFunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "alertStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlertStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "alertType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlertType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Limit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "severity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Severity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriptionServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
