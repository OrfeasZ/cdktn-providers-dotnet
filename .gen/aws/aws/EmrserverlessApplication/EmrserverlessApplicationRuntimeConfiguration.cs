using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationRuntimeConfiguration")]
    public class EmrserverlessApplicationRuntimeConfiguration : aws.EmrserverlessApplication.IEmrserverlessApplicationRuntimeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#classification EmrserverlessApplication#classification}.</summary>
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        public string Classification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/emrserverless_application#properties EmrserverlessApplication#properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Properties
        {
            get;
            set;
        }
    }
}
