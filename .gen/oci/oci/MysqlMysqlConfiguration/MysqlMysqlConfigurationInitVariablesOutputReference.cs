using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlMysqlConfiguration
{
    [JsiiClass(nativeType: typeof(oci.MysqlMysqlConfiguration.MysqlMysqlConfigurationInitVariablesOutputReference), fullyQualifiedName: "oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationInitVariablesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlMysqlConfigurationInitVariablesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlMysqlConfigurationInitVariablesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlMysqlConfigurationInitVariablesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlMysqlConfigurationInitVariablesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLowerCaseTableNames")]
        public virtual void ResetLowerCaseTableNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "lowerCaseTableNamesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LowerCaseTableNamesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lowerCaseTableNames", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LowerCaseTableNames
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.mysqlMysqlConfiguration.MysqlMysqlConfigurationInitVariables\"}", isOptional: true)]
        public virtual oci.MysqlMysqlConfiguration.IMysqlMysqlConfigurationInitVariables? InternalValue
        {
            get => GetInstanceProperty<oci.MysqlMysqlConfiguration.IMysqlMysqlConfigurationInitVariables?>();
            set => SetInstanceProperty(value);
        }
    }
}
