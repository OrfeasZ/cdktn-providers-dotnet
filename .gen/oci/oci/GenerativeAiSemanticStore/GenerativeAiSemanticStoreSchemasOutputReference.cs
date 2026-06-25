using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    [JsiiClass(nativeType: typeof(oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreSchemasOutputReference), fullyQualifiedName: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GenerativeAiSemanticStoreSchemasOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GenerativeAiSemanticStoreSchemasOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GenerativeAiSemanticStoreSchemasOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GenerativeAiSemanticStoreSchemasOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas" />)[]</param>
        [JsiiMethod(name: "putSchemas", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemas\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchemas(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemasList\"}")]
        public virtual oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemasList Schemas
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemasList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemas\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SchemasInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemas\"}", isOptional: true)]
        public virtual oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas? InternalValue
        {
            get => GetInstanceProperty<oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas?>();
            set => SetInstanceProperty(value);
        }
    }
}
