using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azapi.DataAzapiResource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/data-sources/resource azapi_resource}.</summary>
    [JsiiClass(nativeType: typeof(azapi.DataAzapiResource.DataAzapiResource), fullyQualifiedName: "azapi.dataAzapiResource.DataAzapiResource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceConfig\"}}]")]
    public class DataAzapiResource : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/data-sources/resource azapi_resource} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzapiResource(Constructs.Construct scope, string id, azapi.DataAzapiResource.IDataAzapiResourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azapi.DataAzapiResource.IDataAzapiResourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzapiResource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzapiResource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzapiResource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzapiResource to import.</param>
        /// <param name="importFromId">The id of the existing DataAzapiResource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzapiResource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzapiResource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/azure/azapi/2.12.0/docs/data-sources/resource#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzapiResource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzapiResource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azapi.DataAzapiResource.DataAzapiResource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putRetry", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceRetry\"}}]")]
        public virtual void PutRetry(azapi.DataAzapiResource.IDataAzapiResourceRetry @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azapi.DataAzapiResource.IDataAzapiResourceRetry)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceTimeouts\"}}]")]
        public virtual void PutTimeouts(azapi.DataAzapiResource.IDataAzapiResourceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azapi.DataAzapiResource.IDataAzapiResourceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHeaders")]
        public virtual void ResetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreNotFound")]
        public virtual void ResetIgnoreNotFound()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentId")]
        public virtual void ResetParentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryParameters")]
        public virtual void ResetQueryParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceId")]
        public virtual void ResetResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseExportValues")]
        public virtual void ResetResponseExportValues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetry")]
        public virtual void ResetRetry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azapi.DataAzapiResource.DataAzapiResource))!;

        [JsiiProperty(name: "exists", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Exists
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceIdentityList\"}")]
        public virtual azapi.DataAzapiResource.DataAzapiResourceIdentityList Identity
        {
            get => GetInstanceProperty<azapi.DataAzapiResource.DataAzapiResourceIdentityList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"cdktn.AnyMap\"}")]
        public virtual Io.Cdktn.AnyMap Output
        {
            get => GetInstanceProperty<Io.Cdktn.AnyMap>()!;
        }

        [JsiiProperty(name: "retry", typeJson: "{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceRetryOutputReference\"}")]
        public virtual azapi.DataAzapiResource.DataAzapiResourceRetryOutputReference Retry
        {
            get => GetInstanceProperty<azapi.DataAzapiResource.DataAzapiResourceRetryOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceTimeoutsOutputReference\"}")]
        public virtual azapi.DataAzapiResource.DataAzapiResourceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azapi.DataAzapiResource.DataAzapiResourceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? HeadersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreNotFoundInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IgnoreNotFoundInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? QueryParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseExportValuesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, object>? ResponseExportValuesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azapi.DataAzapiResource.IDataAzapiResourceRetry" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceRetry\"}]}}", isOptional: true)]
        public virtual object? RetryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azapi.DataAzapiResource.IDataAzapiResourceTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azapi.dataAzapiResource.DataAzapiResourceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Headers
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ignoreNotFound", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IgnoreNotFound
        {
            get => GetInstanceProperty<object>()!;
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
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, (string)[]&gt;</para>
        /// </remarks>
        [JsiiProperty(name: "queryParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}")]
        public virtual object QueryParameters
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseExportValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, object> ResponseExportValues
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, object>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
