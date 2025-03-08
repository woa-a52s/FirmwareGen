using PartitionOffsetsHelperTool.GPT;
using System;

namespace PartitionOffsetsHelperTool.DeviceProfiles
{
    internal static class Constants
    {
        // OEMEP DV UFS LUN 0 Partition Layout
        internal static readonly GPTPartition[] OEMEP_UFS_LUN_0_PARTITIONS =
        [
            new()
            {
                TypeGUID = new Guid("ebbeadaf-22c9-e33b-8f5d-0e81686a68cb"),
                UID = new Guid("ebbeadaf-22c9-e33b-8f5d-0e81686a68cb"),
                FirstLBA = 265,
                LastLBA = 1032,
                Attributes = 0,
                Name = "modemst1"
            },
            new()
            {
                TypeGUID = new Guid("0a288b1f-22c9-e33b-8f5d-0e81686a68cb"),
                UID = new Guid("0a288b1f-22c9-e33b-8f5d-0e81686a68cb"),
                FirstLBA = 1033,
                LastLBA = 1800,
                Attributes = 0,
                Name = "modemst2"
            },
            new()
            {
                TypeGUID = new Guid("57b90a16-22c9-e33b-8f5d-0e81686a68cb"),
                UID = new Guid("57b90a16-22c9-e33b-8f5d-0e81686a68cb"),
                FirstLBA = 1801,
                LastLBA = 1832,
                Attributes = 0,
                Name = "fsc"
            },
            new()
            {
                TypeGUID = new Guid("2c86e742-745e-4fdd-bfd8-b6a7ac638772"),
                UID = new Guid("2c86e742-745e-4fdd-bfd8-b6a7ac638772"),
                FirstLBA = 1833,
                LastLBA = 1834,
                Attributes = 0,
                Name = "ssd"
            },
            new()
            {
                TypeGUID = new Guid("6c95e238-e343-4ba8-b489-8681ed22ad0b"),
                UID = new Guid("6c95e238-e343-4ba8-b489-8681ed22ad0b"),
                FirstLBA = 1835,
                LastLBA = 10026,
                Attributes = 0,
                Name = "persist"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("d1ebe597-32a6-11ef-a639-dba517b0020e"),
                FirstLBA = 10027,
                LastLBA = 15146,
                Attributes = 0,
                Name = "efs"
            },
            new()
            {
                TypeGUID = new Guid("2da26441-884e-456c-afbb-721626d69933"),
                UID = new Guid("2da26441-884e-456c-afbb-721626d69933"),
                FirstLBA = 15147,
                LastLBA = 17706,
                Attributes = 0,
                Name = "param"
            },
            new()
            {
                TypeGUID = new Guid("a17d0ddb-cec4-4a80-9e22-7d43fec26358"),
                UID = new Guid("a17d0ddb-cec4-4a80-9e22-7d43fec26358"),
                FirstLBA = 17707,
                LastLBA = 20266,
                Attributes = 0,
                Name = "debug"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                FirstLBA = 20267,
                LastLBA = 25386,
                Attributes = 0,
                Name = "sec_efs"
            },
            new()
            {
                TypeGUID = new Guid("82acc91f-357c-4a68-9c8f-689e1b1a23a1"),
                UID = new Guid("82acc91f-357c-4a68-9c8f-689e1b1a23a1"),
                FirstLBA = 25387,
                LastLBA = 25642,
                Attributes = 0,
                Name = "misc"
            },
            new()
            {
                TypeGUID = new Guid("de7d4029-0f5b-41c8-ae7e-f6c023a02b33"),
                UID = new Guid("de7d4029-0f5b-41c8-ae7e-f6c023a02b33"),
                FirstLBA = 25643,
                LastLBA = 25770,
                Attributes = 0,
                Name = "keystore"
            },
            new()
            {
                TypeGUID = new Guid("91b72d4d-71e0-4cbf-9b8e-236381cff17a"),
                UID = new Guid("91b72d4d-71e0-4cbf-9b8e-236381cff17a"),
                FirstLBA = 25771,
                LastLBA = 25898,
                Attributes = 0,
                Name = "frp"
            },
            new()
            {
                TypeGUID = new Guid("66c9b323-f7fc-48b6-bf96-6f32e335a428"),
                UID = new Guid("66c9b323-f7fc-48b6-bf96-6f32e335a428"),
                FirstLBA = 25899,
                LastLBA = 29994,
                Attributes = 0,
                Name = "rawdump"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                FirstLBA = 29995,
                LastLBA = 40334,
                Attributes = 0,
                Name = "bota"
            },
            new()
            {
                TypeGUID = new Guid("18e4f129-dda3-41dc-97fb-cdb0544d3053"),
                UID = new Guid("18e4f129-dda3-41dc-97fb-cdb0544d3053"),
                FirstLBA = 40335,
                LastLBA = 40462,
                Attributes = 0,
                Name = "persistent"
            },
            new()
            {
                TypeGUID = new Guid("2473de82-bb60-418e-9524-19e22790a4ed"),
                UID = new Guid("2473de82-bb60-418e-9524-19e22790a4ed"),
                FirstLBA = 40463,
                LastLBA = 41486,
                Attributes = 0,
                Name = "steady"
            },
            new()
            {
                TypeGUID = new Guid("7efe5010-2a1a-4a1a-b8bc-990257813512"),
                UID = new Guid("7efe5010-2a1a-4a1a-b8bc-990257813512"),
                FirstLBA = 41487,
                LastLBA = 57870,
                Attributes = 0,
                Name = "dsp"
            },
            new()
            {
                TypeGUID = new Guid("ebd0a0a2-b9e5-4433-87c0-68b6b72699c7"),
                UID = new Guid("ebd0a0a2-b9e5-4433-87c0-68b6b72699c7"),
                FirstLBA = 57871,
                LastLBA = 99823,
                Attributes = 0,
                Name = "modem"
            },
            new()
            {
                TypeGUID = new Guid("20117f86-e985-4357-b9ee-374bc1d8487d"),
                UID = new Guid("20117f86-e985-4357-b9ee-374bc1d8487d"),
                FirstLBA = 99824,
                LastLBA = 124399,
                Attributes = 0,
                Name = "boot"
            },
            new()
            {
                TypeGUID = new Guid("9d72d4e4-9958-42da-ac26-bea7a90b0434"),
                UID = new Guid("9d72d4e4-9958-42da-ac26-bea7a90b0434"),
                FirstLBA = 124400,
                LastLBA = 144367,
                Attributes = 0,
                Name = "recovery"
            },
            new()
            {
                TypeGUID = new Guid("6d286a7f-9f1e-46b3-acf4-96a0591fe66f"),
                UID = new Guid("6d286a7f-9f1e-46b3-acf4-96a0591fe66f"),
                FirstLBA = 144368,
                LastLBA = 168943,
                Attributes = 0,
                Name = "vendor_boot"
            },
            new()
            {
                TypeGUID = new Guid("24d0d418-d31d-4d8d-ac2c-4d4305188450"),
                UID = new Guid("24d0d418-d31d-4d8d-ac2c-4d4305188450"),
                FirstLBA = 168944,
                LastLBA = 175087,
                Attributes = 0,
                Name = "dtbo"
            },
            new()
            {
                TypeGUID = new Guid("aceab303-b9e5-4433-87c0-68b6b72699c7"),
                UID = new Guid("aceab303-b9e5-4433-87c0-68b6b72699c7"),
                FirstLBA = 175088,
                LastLBA = 223727,
                Attributes = 0,
                Name = "apnhlos"
            },
            new()
            {
                TypeGUID = new Guid("1344859d-3a6a-4c14-a316-9e696b3a5400"),
                UID = new Guid("1344859d-3a6a-4c14-a316-9e696b3a5400"),
                FirstLBA = 223728,
                LastLBA = 223743,
                Attributes = 0,
                Name = "vbmeta_system"
            },
            new()
            {
                TypeGUID = new Guid("988a98c9-2910-4123-aaec-1cf6b1bc28f9"),
                UID = new Guid("988a98c9-2910-4123-aaec-1cf6b1bc28f9"),
                FirstLBA = 223744,
                LastLBA = 227839,
                Attributes = 0,
                Name = "metadata"
            },
            new()
            {
                TypeGUID = new Guid("89a12de1-5e41-4cb3-8b4c-b1441eb5da38"),
                UID = new Guid("89a12de1-5e41-4cb3-8b4c-b1441eb5da38"),
                FirstLBA = 227840,
                LastLBA = 2826239,
                Attributes = 0,
                Name = "super"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("d1ebe59a-32a6-11ef-a639-dba517b0020e"),
                FirstLBA = 2826240,
                LastLBA = 3031039,
                Attributes = 0,
                Name = "prism"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("d1ebe59b-32a6-11ef-a639-dba517b0020e"),
                FirstLBA = 3031040,
                LastLBA = 3036159,
                Attributes = 0,
                Name = "optics"
            },
            new()
            {
                TypeGUID = new Guid("5594c694-c871-4b5f-90b1-690a6f68e0f7"),
                UID = new Guid("5594c694-c871-4b5f-90b1-690a6f68e0f7"),
                FirstLBA = 3036160,
                LastLBA = 3189759,
                Attributes = 0,
                Name = "cache"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("d1ebe59c-32a6-11ef-a639-dba517b0020e"),
                FirstLBA = 3189760,
                LastLBA = 3202559,
                Attributes = 0,
                Name = "omr"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("d1ebe59d-32a6-11ef-a639-dba517b0020e"),
                FirstLBA = 3202560,
                LastLBA = 3215359,
                Attributes = 0,
                Name = "spu"
            },
            new()
            {
                TypeGUID = new Guid("7bf9ae4a-5610-45f0-86c0-9f60f2bf832f"),
                UID = new Guid("7bf9ae4a-5610-45f0-86c0-9f60f2bf832f"),
                FirstLBA = 3215360,
                LastLBA = 3216383,
                Attributes = 0,
                Name = "testparti"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                FirstLBA = 3216384,
                LastLBA = 3229695,
                Attributes = 0,
                Name = "keyrefuge"
            },
            new()
            {
                TypeGUID = new Guid("0fc63daf-8483-4772-8e79-3d69d8477de4"),
                UID = new Guid("b0a09eaf-4f77-47c2-972b-ea2060280a32"),
                FirstLBA = 3229696,
                LastLBA = 3229695,
                Attributes = 0,
                Name = "userdata"
            }
        ];

        // OEMZE MP UFS LUN 0 Partition Layout
        internal static readonly GPTPartition[] OEMZE_UFS_LUN_0_PARTITIONS =
        [
            new()
            {
                TypeGUID = new Guid("2c86e742-745e-4fdd-bfd8-b6a7ac638772"),
                UID = new Guid("dd334fea-6336-1cfc-9b54-625a4f119d3b"),
                FirstLBA = 6,
                LastLBA = 7,
                Attributes = 0,
                Name = "ssd"
            },
            new()
            {
                TypeGUID = new Guid("6c95e238-e343-4ba8-b489-8681ed22ad0b"),
                UID = new Guid("9c508206-a952-e02d-73dd-25b08eda76e4"),
                FirstLBA = 8,
                LastLBA = 8199,
                Attributes = 0,
                Name = "persist"
            },
            new()
            {
                TypeGUID = new Guid("988a98c9-2910-4123-aaec-1cf6b1bc28f9"),
                UID = new Guid("5e514cb8-1151-c29c-830f-5bf399b40c74"),
                FirstLBA = 8200,
                LastLBA = 12295,
                Attributes = 0,
                Name = "metadata"
            },
            new()
            {
                TypeGUID = new Guid("91b72d4d-71e0-4cbf-9b8e-236381cff17a"),
                UID = new Guid("dd11345e-4c1f-99ee-afd0-e55e6ecc92d6"),
                FirstLBA = 12296,
                LastLBA = 12423,
                Attributes = 0,
                Name = "frp"
            },
            new()
            {
                TypeGUID = new Guid("82acc91f-357c-4a68-9c8f-689e1b1a23a1"),
                UID = new Guid("035e02e0-4bb9-06ce-4851-a1ec88834507"),
                FirstLBA = 12424,
                LastLBA = 12679,
                Attributes = 0,
                Name = "misc"
            },
            new()
            {
                TypeGUID = new Guid("66c9b323-f7fc-48b6-bf96-6f32e335a428"),
                UID = new Guid("68733ebb-ef36-f8ca-11e9-893ace2e6585"),
                FirstLBA = 12680,
                LastLBA = 89479,
                Attributes = 0,
                Name = "rawdump"
            },
            new()
            {
                TypeGUID = new Guid("21adb864-c9e7-4c76-be68-568e20c58439"),
                UID = new Guid("d296e468-eba2-dfe6-23d5-3b5cb3a853d9"),
                FirstLBA = 89480,
                LastLBA = 97835,
                Attributes = 0,
                Name = "vm-data"
            },
            new()
            {
                TypeGUID = new Guid("1b81e7e6-f50d-419b-a739-2aeef8da3335"),
                UID = new Guid("411d7753-d116-25ee-ca31-6436766e9580"),
                FirstLBA = 97836,
                LastLBA = 97835,
                Attributes = 0,
                Name = "userdata"
            }
        ];
    }
}