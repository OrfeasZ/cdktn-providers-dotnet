using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardAdhocQuery
{
    [JsiiClass(nativeType: typeof(oci.CloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsOutputReference), fullyQualifiedName: "oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudGuardAdhocQueryAdhocQueryDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudGuardAdhocQueryAdhocQueryDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudGuardAdhocQueryAdhocQueryDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudGuardAdhocQueryAdhocQueryDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdhocQueryResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdhocQueryResources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "adhocQueryResources", typeJson: "{\"fqn\":\"oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResourcesList\"}")]
        public virtual oci.CloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResourcesList AdhocQueryResources
        {
            get => GetInstanceProperty<oci.CloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResourcesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adhocQueryResourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdhocQueryResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetails\"}", isOptional: true)]
        public virtual oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
