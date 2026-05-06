using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveTypeGroupGroupedSensitiveType
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type oci_data_safe_sensitive_type_group_grouped_sensitive_type}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveType), fullyQualifiedName: "oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig\"}}]")]
    public class DataSafeSensitiveTypeGroupGroupedSensitiveType : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type oci_data_safe_sensitive_type_group_grouped_sensitive_type} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataSafeSensitiveTypeGroupGroupedSensitiveType(Constructs.Construct scope, string id, oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSensitiveTypeGroupGroupedSensitiveType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSensitiveTypeGroupGroupedSensitiveType(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataSafeSensitiveTypeGroupGroupedSensitiveType resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataSafeSensitiveTypeGroupGroupedSensitiveType to import.</param>
        /// <param name="importFromId">The id of the existing DataSafeSensitiveTypeGroupGroupedSensitiveType that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataSafeSensitiveTypeGroupGroupedSensitiveType to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataSafeSensitiveTypeGroupGroupedSensitiveType to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataSafeSensitiveTypeGroupGroupedSensitiveType that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataSafeSensitiveTypeGroupGroupedSensitiveType to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveType), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPatchOperations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPatchOperations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchOperations")]
        public virtual void ResetPatchOperations()
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
        = GetStaticProperty<string>(typeof(oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveType))!;

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeItemsList\"}")]
        public virtual oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeItemsList Items
        {
            get => GetInstanceProperty<oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeItemsList>()!;
        }

        [JsiiProperty(name: "patchOperations", typeJson: "{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperationsList\"}")]
        public virtual oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperationsList PatchOperations
        {
            get => GetInstanceProperty<oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperationsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeoutsOutputReference\"}")]
        public virtual oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchOperationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PatchOperationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sensitiveTypeGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SensitiveTypeGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sensitiveTypeGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SensitiveTypeGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
